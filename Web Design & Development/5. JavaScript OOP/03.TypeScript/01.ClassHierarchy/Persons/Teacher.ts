module Persons {
    'use strict';

    export class Teacher extends Persons.Person implements Interfaces.ITeacher {
        private _experience: string;
        private _disciplines: string[];

        constructor(fullname: string, id: string, experience: string, disciplines?: string[]) {
            var isAllDisciplinesValid: boolean = true; 
            super(fullname, id);
            this.experience = experience;

            if (disciplines) {
                disciplines.forEach(currentDiscipline => {
                    if (!Education.Discipline.isDisciplineValid(currentDiscipline)) {
                        throw new Error('There is no such discipline!');
                    }
                });

                this._disciplines = disciplines;
            }
            else {
                this._disciplines = [];
            }
        }

        public get experience(): string {
            return this._experience;
        }

        public set experience(experience: string) {
            if (experience === null || experience === '') {
                throw new Error('Experience cannot be null or empty!');
            }
            
            this._experience = experience;
        }

        public get disciplines(): string[] {
            return this._disciplines;
        }

        public addDiscipline(discipline: string): void {
            if (!Education.Discipline.isDisciplineValid(discipline)) {
                throw new Error('There is no such discipline!');
            }
            else if (this.containsDiscipline(discipline)) {
                throw new Error('Discipline already exist!');
            }

            this._disciplines.push(discipline);
        }

        public containsDiscipline(discipline: string): boolean {
            return this._disciplines.indexOf(discipline) !== -1;
        }

        public removeDiscipline(discipline: string): boolean {
            if (this.containsDiscipline(discipline)) {
                var disciplineIndex = this._disciplines.indexOf(discipline);
                this._disciplines[disciplineIndex] = this._disciplines[this._disciplines.length - 1];
                this._disciplines.pop();
                return true;
            }

            return false;
        }

        public printTeacher(): void {
            super.printPerson();
            console.log('Experience: ' + this.experience);
            console.group('Disciplines: ');

            if (this._disciplines.length > 0) {    
                this._disciplines.forEach(discipline => {
                    console.log(discipline);
                });
            }
            else {
                console.log('There are no disciplines!');
            }

            console.groupEnd();
            console.log('\n');
        }
    }
} 