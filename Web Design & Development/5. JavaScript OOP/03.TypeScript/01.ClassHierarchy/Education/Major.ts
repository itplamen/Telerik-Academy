module Education {
    'use strict';

    export class Major implements Interfaces.IMajor {
        private _majorType: string;
        private _students: Persons.Student[];

        constructor(majorType: string, students?: Persons.Student[]) {
            this.majorType = majorType;
            
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
                throw new Error('There is no sych major type!');
            }

            this._majorType = majorType;
        }

        public get students(): Persons.Student[] {
            return this._students;
        }

        public addStudent(student: Persons.Student): void {
            this._students.push(student);
        }

        public containsStudent(student: Persons.Student): boolean {
            return this._students.indexOf(student) !== -1;
        }

        public removeStudent(student: Persons.Student): boolean {
            if (this.containsStudent(student)) {
                var studentIndex: number = this._students.indexOf(student);
                this._students[studentIndex] = this._students[this._students.length - 1];
                this._students.pop();
                return true
            }
            
            return false;
        }

        public clearStudents(): void {
            this._students = [];
        }

        public printMajor(): void {
            console.group('Major: ' + this.majorType);
            console.group('Students: ');

            if (this._students.length > 0) {    
                this._students.forEach(student => {
                    student.printStudent();
                });

                console.groupEnd();
            }
            else {
                console.log('There are no students in this major!');
            }

            console.groupEnd();
        }
    }
} 