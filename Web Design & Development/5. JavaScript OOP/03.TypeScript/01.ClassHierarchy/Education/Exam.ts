module Education {
    'use strict';

    export class Exam<T extends Interfaces.ITeacher, S extends Interfaces.IStudent> {
        private _majorType: string;
        private _discipline: string;
        private _teacher: T;
        private _students: S[];

        constructor(majorType: string, discipline: string, teacher: T, students: S[]) {
            this.majorType = majorType;
            this.discipline = discipline;
            this._teacher = teacher;

            if (students) {
                this._students = students;
            }
            else {
                this._students = [];
            }
        }

        public get majorType(): string {
            return this._majorType;
        }

        public set majorType(majorType: string) {
            if (!Education.MajorType.isMajorTypeValid(majorType)) {
                throw new Error('There is no such major type!');
            }

            this._majorType = majorType;
        }

        public get discipline(): string {
            return this._discipline;
        }

        public set discipline(discipline: string) {
            if (!Education.Discipline.isDisciplineValid(discipline)) {
                throw new Error('There is no such discipline!');
            }

            this._discipline = discipline;
        }

        public get teacher(): T {
            return this._teacher;
        }

        public get students(): S[] {
            return this._students;
        }

        public printExam(): void {
            console.group('Exam: ');
            console.log('Major: ' + this._majorType + ', Discipline: ' + this._discipline);
            console.log('Teacher: ');
            this._teacher.printTeacher();
            console.log('Students: ');

            this._students.forEach(student => {
                student.printStudent();
            });

            console.groupEnd();
        }
    }
} 