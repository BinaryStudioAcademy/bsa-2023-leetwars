import { HttpParams } from '@angular/common/http';

function notEmpty<T>(value: T): boolean {
    return !!value || typeof value === 'number';
}

function setArrayOfValues(params: HttpParams, key: string, arrayValues: string[]): HttpParams {
    return arrayValues.reduce((prevParams, value) => {
        if (notEmpty(value)) {
            return prevParams.append(key, encodeURIComponent(String(value)));
        }

        return prevParams;
    }, params);
}

/**
 * Set immutable http parameters from object properties
 * httpParams = setParams<RequestFilter>(httpParams, requestFilter);
 */
export function setParams<T>(params: HttpParams, obj?: T): HttpParams {
    if (!obj) {
        return params;
    }

    let newParams = params;

    Object.keys(obj).forEach((key) => {
        const filterKey = key as keyof typeof obj;

        if (Array.isArray(obj[filterKey])) {
            newParams = setArrayOfValues(newParams, key, obj[filterKey] as unknown as string[]);

            return;
        }

        if (notEmpty(obj[filterKey])) {
            newParams = newParams.set(key, encodeURIComponent(String(obj[filterKey])));
        }
    });

    return newParams;
}
