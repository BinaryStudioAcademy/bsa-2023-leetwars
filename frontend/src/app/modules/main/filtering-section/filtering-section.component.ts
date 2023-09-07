import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { StarService } from '@core/services/star.service';
import { TagService } from '@core/services/tag.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { PROGRESS_NAMES_MAP, STATUS_NAMES_MAP } from '@modules/main/filtering-section/filtering-section.utils';
import { ChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { Star } from '@shared/models/challenge-star/star';
import { Language } from '@shared/models/language/language';
import { PageSettings } from '@shared/models/page-settings';
import { Tag } from '@shared/models/tag/tag';
import { User } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-filtering-section',
    templateUrl: './filtering-section.component.html',
    styleUrls: ['./filtering-section.component.sass'],
})
export class FilteringSectionComponent extends BaseComponent implements OnInit {
    public challenges: ChallengePreview[] = [];

    public loading = false;

    public languagesNames: string[] = [];

    public statusesNames: string[] = [];

    public progressesNames: string[] = [];

    public tagsNames: string[] = [];

    private page: PageSettings = {
        pageNumber: 0,
        pageSize: 10,
    };

    private isLastPage = false;

    private filter: ChallengeFilter = {
        title: '',
        tagsIds: [],
    };

    private progresses = PROGRESS_NAMES_MAP;

    private tags: Tag[] = [];

    private languages: Language[] = [];

    private statuses = STATUS_NAMES_MAP;

    private user: User;

    constructor(
        private challengeService: ChallengeService,
        private languageService: LanguageService,
        private tagService: TagService,
        private starService: StarService,
        private authService: AuthService,
        private toastrService: ToastrNotificationsService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getChalenges();
        this.getLanguages();
        this.getTags();

        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });

        this.statusesNames = this.statuses.map((item) => item.name);
        this.progressesNames = this.progresses.map((item) => item.name);
    }

    public onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getChalenges();
    }

    public onSearchTextChange(value: string) {
        this.filter.title = value;
        this.resetChallengesData();
    }

    public onLanguageChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.languageId = this.languages.find((item) => item.name === value)?.id;
        this.resetChallengesData();
    }

    public onStatusChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.challengeStatus = this.statuses.find((item) => item.name === value)?.status;
        this.resetChallengesData();
    }

    public onProgressChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.progress = this.progresses.find((item) => item.name === value)?.state;
        this.resetChallengesData();
    }

    public onTagsChange(value: string | string[]) {
        if (typeof value === 'string') {
            return;
        }

        this.filter.tagsIds = value
            .map((tagName) => this.tags.find((item) => item.name === tagName)?.id ?? 0)
            .filter((item) => item !== 0);

        this.resetChallengesData();
    }

    public updateChallengeStar(challenge: ChallengePreview) {
        const star: Star = {
            authorId: this.user.id,
            challenge,
            isStar: !challenge.isStarry,
        };

        this.starService.updateStar(star).subscribe((starResp: Star) => {
            challenge.isStarry = starResp.isStar;
        });
    }

    private getChalenges() {
        if (this.isLastPage) {
            return;
        }

        this.page.pageNumber++;
        this.loading = true;

        this.challengeService
            .getChallenges(this.filter, this.page)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.loading = false;
                    if (!data.length) {
                        this.isLastPage = true;

                        return;
                    }
                    this.challenges = [...this.challenges, ...data];
                },
                error: () => {
                    this.loading = false;
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getTags() {
        this.tagService
            .getTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.tags = data;
                    this.tagsNames = ['All', ...data.map((tag) => tag.name)];
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getLanguages() {
        this.languageService
            .getLanguages()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.languages = data;
                    this.languagesNames = ['All', ...data.map((language) => language.name)];
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private resetChallengesData() {
        this.challenges = [];
        this.page.pageNumber = 0;
        this.isLastPage = false;
        this.getChalenges();
    }
}
