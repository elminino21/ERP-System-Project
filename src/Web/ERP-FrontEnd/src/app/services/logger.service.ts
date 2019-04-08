import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {

  constructor() { }

  logError(message: any) {
        console.error(message);
    }

    logWarning(message: any) {
            console.warn(message);
    }

    logDebug(message: any) {
            console.log(message);
    }
}
