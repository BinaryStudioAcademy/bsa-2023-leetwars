export interface ChallengeFilter {
    title: string,
    challengeStatus?: number,
    languageId?: number,
    tagsIds: number[],
    progress?: number,
}
