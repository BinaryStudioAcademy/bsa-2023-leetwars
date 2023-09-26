import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private localStorageItem: string = 'unreadNotifications';

    private newNotificationsCollection: INotificationModel[] = [];

    private seenNotificationsCollection: INotificationModel[] = [];

    public get countNotification() {
        return this.newNotifications.length;
    }

    public get newNotifications() {
        return this.newNotificationsCollection;
    }

    public get seenNotifications() {
        return this.seenNotificationsCollection;
    }

    constructor() {
        this.newNotificationsCollection = this.getUnreadFromLocalStorage();
    }

    public addNewNotification(notification: INotificationModel) {
        this.saveNewNotificationToLocalStorage(notification);

        this.newNotificationsCollection = [...this.newNotificationsCollection, notification];
    }

    public readNofitications() {
        this.clearLocalStorageOnRead();
        this.seenNotificationsCollection = [...this.seenNotificationsCollection, ...this.newNotificationsCollection];
        this.newNotificationsCollection = [];
    }

    private saveNewNotificationToLocalStorage(notification: INotificationModel) {
        const newNotificationArray = [...this.getUnreadFromLocalStorage(), notification];

        localStorage.setItem(`${this.localStorageItem}`, JSON.stringify(newNotificationArray));
    }

    private clearLocalStorageOnRead() {
        localStorage.removeItem(`${this.localStorageItem}`);
    }

    private getUnreadFromLocalStorage() {
        return JSON.parse(localStorage.getItem(`${this.localStorageItem}`) ?? '[]');
    }
}
