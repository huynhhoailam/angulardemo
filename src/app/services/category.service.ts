import { Injectable } from '@angular/core';
import { Observable, throwError, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ICategory } from '../models/category';
import { HttpHeaders, HttpClient, HttpErrorResponse } from '@angular/common/http';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};

@Injectable()

export class CategoryService {
    constructor(private http: HttpClient) {}

    GetAllCategories(url: string): Observable<ICategory[]> {
        return this.http.get<ICategory[]>(url).pipe(catchError(this.handleError));
    }

    AddCategory(url: string, category: ICategory): Observable<any> {
        return this.http.post(url, JSON.stringify(category), httpOptions).pipe(catchError(this.handleError));
    }

    UpdateCategory(url: string, id: number, category: ICategory): Observable<any> {
        const newurl = `${url}?id=${id}`;
        return this.http.put(newurl, category, httpOptions).pipe(catchError(this.handleError));
    }

    DeleteCategory(url: string, id: number): Observable<any> {
        const newurl = `${url}?id=${id}`;
        return this.http.delete(newurl, httpOptions).pipe(catchError(this.handleError));
    }

    SearchCategory(url: string, search: string): Observable<ICategory[]> {
        if (!search.trim()) {
            return of([]);
        }

        return this.http.get<ICategory[]>(`${url}/?categoryName=${search}`).pipe(catchError(this.handleError));
    }

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            console.log('An error ocurred: ', error.error.message);
        } else {
            console.error(
                `Backend returned code ${error.status},` + `body was: ${error.error}`
            );
        }
        return throwError('Something bad happened. Please try again later.');
    }
}
