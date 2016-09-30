module Persons {
    'use strict';

    export class Student extends Persons.Person implements Interfaces.IStudent {
        private static MIN_COURSE = 1;
        private static MAX_COURSE = 5;
        private static MIN_MARK = 2;
        private static MAX_MARK = 6;
        private _course: number;
        private _facultyNumber: string;
        private _marks: number[];
        private static _facultyNumbers: string[] = [];

        constructor(fullname: string, id: string, course: number, facultyNumber: string) {
            super(fullname, id);
            this.course = course;
            this.facultyNumber = facultyNumber;
            this._marks = [];
        }

        public get course(): number {
            return this._course;
        }

        public set course(course) {
            if (course < Student.MIN_COURSE || course > Student.MAX_COURSE) {
                throw new Error('Course must be in the interval [' + Student.MIN_COURSE + ' - ' + Student.MAX_COURSE + ']!');
            }
            
            this._course = course;
        }

        public get facultyNumber(): string {
            return this._facultyNumber;
        }

        public set facultyNumber(facultyNumber: string) {
            if (facultyNumber === null || facultyNumber === '') {
                throw new Error('Faculty number cannot be null or empty!');
            }
            else if (Student.isFacultyNumberAlreadyExist(facultyNumber)) {
                throw new Error('Faculty number already exist!');
            }

            this._facultyNumber = facultyNumber;
            Student._facultyNumbers.push(facultyNumber);
        }

        public get marks(): number[] {
            return this._marks;
        }

        public addMark(discipline: string, mark: number): void {
            var disciplineMarks: number[] = [];
            this.isDisciplineValid(discipline)
          
            if (!this.isMarkValid(mark)) {
                throw new Error('Mark must be an integer number in interval [' + Student.MIN_MARK + ' - ' + Student.MAX_MARK + ']!');
            }

            if (!this._marks[discipline]) {
                this._marks[discipline] = [mark];
            }
            else {
                disciplineMarks = this._marks[discipline];
                disciplineMarks.push(mark);
                this._marks[discipline] = disciplineMarks;
            }
        }

        public addMarks(discipline: string, marks: number[]): void {
            this.isDisciplineValid(discipline);

            marks.forEach(mark => {
                if (!this.isMarkValid(mark)) {
                    throw new Error('Mark must be an integer number in interval [' + Student.MIN_MARK + ' - ' + Student.MAX_MARK + ']!');
                }
            });

            this._marks[discipline] = marks;
        }

        public getAverageMark(discipline: string): number {
            var disciplineMarks: number[] = this._marks[discipline],
                averageMark = 0;

            this.isDisciplineValid(discipline);
            disciplineMarks.forEach(mark => {
                averageMark += mark;
            });

            return averageMark / disciplineMarks.length;
        }

        public clearMarks(): void {
            this._marks = [];
        }

        public printStudent(): void {
            var discipline;

            super.printPerson();
            console.log('Course: ' + this.course + ', Faculty number: ' + this.facultyNumber);
            console.group('Marks: ');

            for (discipline in this._marks) {
                console.log(discipline + ': ' + '[' + this._marks[discipline] + '] -> ' + this.getAverageMark(discipline));
            }

            if (!discipline) {
                console.log('There are no marks!');
            }

            console.groupEnd();
            console.log('\n');
        }

        private static isFacultyNumberAlreadyExist(facultyNumber: string): boolean {
            return Student._facultyNumbers.indexOf(facultyNumber) !== -1;
        }

        private isDisciplineValid(discipline: string): boolean {
            if (discipline === null || discipline === '') {
                throw new Error('Discipline cannot be null or empty!');
            }
            else if (!Education.Discipline.isDisciplineValid(discipline)) {
                throw new Error('There is no such discipline!');
            }

            return true;
        }

        private isMarkValid(mark: number): boolean {
            return (mark >= Student.MIN_MARK && mark <= Student.MAX_MARK) &&
                (parseInt(mark.toString()) === parseFloat(mark.toString()));
        }
    }
} 
