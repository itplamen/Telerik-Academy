module Interfaces {
    'use strict';

    export interface ITeacher {
        addDiscipline(discipline: Education.Discipline): void;
        containsDiscipline(discipline: Education.Discipline): boolean;
        removeDiscipline(discipline: Education.Discipline): boolean;
        printTeacher(): void;
    }
} 