module Interfaces {
    'use strict';

    export interface IMajor {
        addStudent(student: Persons.Student): void; 
        containsStudent(student: Persons.Student): boolean;
        removeStudent(student: Persons.Student): void;
        clearStudents(): void;
        printMajor(): void;
    }
} 