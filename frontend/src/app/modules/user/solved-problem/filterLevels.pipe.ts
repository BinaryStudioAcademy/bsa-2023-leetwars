import { Pipe, PipeTransform } from '@angular/core';
import { Challenge } from '@shared/models/challenge/challenge';

@Pipe({ name: 'filterByLevel' })
export class FilterByLevelPipe implements PipeTransform {
    transform(challenges: Challenge[], level: string): number {
        if (challenges) {
            return challenges.filter(
                (challenge: Challenge) => challenge.level.name.toLowerCase() === level.toLowerCase(),
            ).length;
        }

        return 0;
    }
}
