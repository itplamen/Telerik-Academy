module Education {
    'use strict';

    export class University implements Interfaces.IUniversity {
        private _universityName: string;
        private _teachers: Persons.Teacher[];
        private _majors: Education.Major[];

        constructor(universityName: string, teachers?: Persons.Teacher[], majors?: Education.Major[]) {
            this.universityName = universityName;

            if (teachers) {
                this._teachers = teachers;
            }
            else {
                this._teachers = [];
            }

            if (majors) {
                this._majors = majors;
            }
            else {
                this._majors = [];
            }
        }

        public get universityName(): string {
            return this._universityName;
        }

        public set universityName(universityName: string) {
            if (universityName === null || universityName === '') {
                throw new Error('University name cannot be null or empty!');
            }
             
            this._universityName = universityName;
        }

        public get teachers(): Persons.Teacher[] {
            return this._teachers;
        }

        public get majors(): Education.Major[] {
            return this._majors;
        }

        public addTeacher(teacher: Persons.Teacher): void {
            this._teachers.push(teacher);
        }

        public containsTeacher(teacher: Persons.Teacher): boolean {
            return this._teachers.indexOf(teacher) !== - 1;
        }

        public removeTeacher(teacher: Persons.Teacher): boolean {
            if (this.containsTeacher(teacher)) {
                var teacherIndex: number = this._teachers.indexOf(teacher);
                this._teachers[teacherIndex] = this._teachers[this._teachers.length - 1];
                this._teachers.pop();
                return true;
            }

            return false;
        }

        public addMajor(major: Education.Major): void {
            if (this.containsMajor(major)) {
                throw new Error('Major already exist!');
            }

            this._majors.push(major);
        }

        public containsMajor(major: Education.Major): boolean {
            return this._majors.indexOf(major) !== - 1;
        }

        public removeMajor(major: Education.Major): boolean {
            if (this.containsMajor(major)) {
                var majorIndex: number = this._majors.indexOf(major);
                this._majors[majorIndex] = this._majors[this._majors.length - 1];
                this._majors.pop();
                return true;
            }

            return false;
        }

        public getNumberOfStudents(): number {
            var numberOfStudents: number = 0;

            this._majors.forEach(major => {
                numberOfStudents += major.students.length;
            });

            return numberOfStudents;
        }

        public printUniversity(): void {
            console.group('University name: ' + this.universityName);
            console.log('Number of teachers: ' + this._teachers.length);
            console.log('Number of majors: ' + this._majors.length);
            console.log('Number of students: ' + this.getNumberOfStudents());

            if (this._teachers.length > 0) {
                console.group('Teachers: ');
                this._teachers.forEach(teacher => {
                    teacher.printTeacher();
                });
                console.groupEnd();
            }

            if (this._majors.length > 0) {
                console.group('Majors: ');
                this._majors.forEach(major => {
                    major.printMajor();
                });
                console.groupEnd();
            }

            console.groupEnd();
        }
    }
} 