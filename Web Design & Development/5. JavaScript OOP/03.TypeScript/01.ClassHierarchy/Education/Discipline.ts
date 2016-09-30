module Education {
    'use strict';

    export class Discipline {
        private static _oop: string = 'OOP';
        private static _criptography: string = 'Cryptography';
        private static _math: string = 'Math';
        private static _javaProgramming: string = 'JAVA Programming';
        private static _english: string = 'English';
        private static _database: string = 'Database';
        private static _artificialIntelligence: string = 'Artificial Intelligence';
        private static _webDesign: string = 'Web Design';
        private static _disciplines: string[] = [Discipline._oop, Discipline._criptography, Discipline._math, Discipline._javaProgramming,
        Discipline._english, Discipline._database, Discipline._artificialIntelligence, Discipline._webDesign];

        public static get OOP(): string {
            return Discipline._oop;
        }

        public static get Criptography(): string {
            return Discipline._criptography;
        }

        public static get Math(): string {
            return Discipline._math;
        }

        public static get JavaProgramming(): string {
            return Discipline._javaProgramming;
        }

        public static get English(): string {
            return Discipline._english;
        }

        public static get Database(): string {
            return Discipline._database;
        }

        public static get ArtificialIntelligence(): string {
            return Discipline._artificialIntelligence;
        }

        public static get WebDesign(): string {
            return Discipline._webDesign;
        }

        public static get Disciplines(): string[] {
            return Discipline._disciplines;
        }

        public static isDisciplineValid(discipline: string): boolean {
            if (discipline === null || discipline === '') {
                throw new Error('Discipline cannot be null or empty!');
            }

            for (var i = 0; i < Discipline._disciplines.length; i += 1) {
                if (Discipline._disciplines[i] === discipline) {
                    return true;
                }
            }
            
            return false;
        }
    }
} 