module Interfaces {
    'use strict';

    export interface IStudent {
        addMark(discipline: string, mark: number): void;
        addMarks(discipline: string, arrayOfMarks: number[]): void;
        getAverageMark(discipline: string): number;
        clearMarks(): void;
        printStudent(): void;
    }
} 