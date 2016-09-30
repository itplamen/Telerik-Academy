module Interfaces {
    'use strict';

    export interface IUniversity {
        addTeacher(teacher: Persons.Teacher): void;
        containsTeacher(teacher: Persons.Teacher): boolean;
        removeTeacher(teacher: Persons.Teacher): boolean;
        addMajor(major: Education.Major): void;
        containsMajor(major: Education.Major): boolean;
        removeMajor(major: Education.Major): boolean;
        getNumberOfStudents(): number;
        printUniversity(): void;
    } 
}