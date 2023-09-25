import { Component, Input, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { LanguageLevel } from '@shared/enums/language-level';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { ICodeFightChallengeSettings } from '@shared/models/codefight/code-fight-challenge-settings';
import { ICodeFightRequest } from '@shared/models/codefight/code-fight-request';
import { ILanguage } from '@shared/models/language/language';
import { IUser } from '@shared/models/user/user';

@Component({
    selector: 'app-challenge-selection-modal',
    templateUrl: './challenge-selection-modal.component.html',
    styleUrls: ['./challenge-selection-modal.component.sass'],
})
export class ChallengeSelectionModalComponent implements OnInit {
    @Input() languages: ILanguage[];

    @Input() levels: IChallengeLevel[];

    @Input() receiverId: number;

    public languagesNames: string[];

    public levelsNames: string[];

    private currentUser: IUser;

    private fightChallengeSettings: ICodeFightChallengeSettings = {
        languageId: 1,
        level: LanguageLevel.Easy,
    };

    constructor(
        public activeModal: NgbActiveModal,
        private authService: AuthService,
        private challengeService: ChallengeService,
    ) {}

    public ngOnInit(): void {
        this.languagesNames = this.languages.map((item) => item.name);
        this.levelsNames = this.levels.map((item) => item.skillLevel);
        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });
    }

    public confirmCodeFightRequest() {
        const codeFightRequest: ICodeFightRequest = {
            challengeSettings: this.fightChallengeSettings,
            receiverId: this.receiverId,
            senderId: this.currentUser.id,
        };

        this.challengeService.sendCodeFightRequest(codeFightRequest).subscribe((users: IUser[]) => {
            this.activeModal.close(users);
        });
    }

    public onLanguageChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.fightChallengeSettings.languageId = this.languages.find((language) => language.name === value)?.id ?? 0;
    }

    public onLevelChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.fightChallengeSettings.level = this.levels.find((level) => level.skillLevel === value)?.skillLevel ?? LanguageLevel.Easy;
    }
}
