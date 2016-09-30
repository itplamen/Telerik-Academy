module Persons {
    'use strict';

    export class Person {
        private static MIN_AGE: number = 0;
        private static MAX_AGE: number = 100;
        private static MAX_DIGITS_IN_ID = 10;
        private _fullName: string;
        private _id: string;
        private static _idNumbers: string[] = [];
        
        constructor(fullName: string, id: string) {
            this.fullName = fullName;
            this.id = id;
        }

        public get fullName(): string {
            return this._fullName;
        }

        public set fullName(fullName: string) {
            if (fullName === null || fullName === '') {
                throw new Error('Full name cannot be null or empty!');
            }
             
            this._fullName = fullName;
        }

        public get id(): string {
            return this._id;
        }

        public set id(idNumber: string) {
            if (idNumber === null || idNumber === '') {
                throw new Error('ID number cannot be null or empty!');
            }
            else if (!this.isIdValid(idNumber)) {
                throw new Error('ID number must contains ' + Person.MAX_DIGITS_IN_ID + ' digits!');
            }
            else if (Person.isIdAlreadyExist(idNumber)) {
                throw new Error('ID number already exist!');
            }

            this._id = idNumber;
            Person._idNumbers.push(idNumber);
        }

        public printPerson(): void {
            console.log('Full name: ' + this.fullName + ', ID: ' + this.id);
        }

        private isIdValid(id: string): boolean {
            if (id.length !== 10) {
                return false;
            }
            else if (!(/^\d+$/.test(id))) {
                return false;
            }
            
            return true;
        }

        private static isIdAlreadyExist(id: string): boolean {
            return Person._idNumbers.indexOf(id) !== -1;
        }
    }
}
 