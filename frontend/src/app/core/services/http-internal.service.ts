import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '@env/environment';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class HttpInternalService {
    public baseUrl: string = environment.coreUrl;

    public headers = new HttpHeaders();

    // eslint-disable-next-line no-empty-function
    constructor(private http: HttpClient) {}

    private getHeaders(): HttpHeaders {
        return this.headers;
    }

    private getHeader(key: string): string {
        return this.headers.get(key) as string;
    }

    private setHeader(key: string, value: string): void {
        this.headers = this.headers.set(key, value);
    }

    private deleteHeader(key: string): void {
        this.headers = this.headers.delete(key);
    }

    public getRequest<T>(url: string, httpParams?: HttpParams): Observable<T> {
        return this.http
            .get<T>(this.buildUrl(url), { headers: this.getHeaders(), params: httpParams })
            .pipe(catchError(this.handleError));
    }

    public postRequest<T>(url: string, payload: object, httpParams?: HttpParams): Observable<T> {
        return this.http
            .post<T>(this.buildUrl(url), payload, { headers: this.getHeaders(), params: httpParams })
            .pipe(catchError(this.handleError));
    }

    public putRequest<T>(url: string, payload: object, httpParams?: HttpParams): Observable<T> {
        return this.http
            .put<T>(this.buildUrl(url), payload, { headers: this.getHeaders(), params: httpParams })
            .pipe(catchError(this.handleError));
    }

    public deleteRequest<T>(url: string, httpParams?: HttpParams): Observable<T> {
        return this.http
            .delete<T>(this.buildUrl(url), { headers: this.getHeaders(), params: httpParams })
            .pipe(catchError(this.handleError));
    }

    private handleError(error: HttpErrorResponse) {
        return throwError(() => new Error(error.message ?? 'An error occurred'));
    }

    private buildUrl(url: string): string {
        if (url.startsWith('http://') || url.startsWith('https://')) {
            return url;
        }

        return this.baseUrl + url;
    }
}
