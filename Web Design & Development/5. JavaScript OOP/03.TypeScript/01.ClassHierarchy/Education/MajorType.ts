module Education {
    'use strict';

    export class MajorType {
        private static _electronics: string = 'Electronics';
        private static _mechanicalEngineering: string = 'Mechanical Engineering';
        private static _computerScience: string = 'Computer Science';
        private static _businessManagement: string = 'Business Management';
        private static _geography: string = 'Geography';
        private static _math: string = 'Math';
        private static _marketing: string = 'Marketing';
        private static _chemistry: string = 'Chemistry';
        private static _economy: string = 'Economy';
        private static _law: string = 'Law';
        private static _computerTechnology: string = 'Computer Technology';
        private static _majorTypes: string[] = [MajorType._electronics, MajorType._mechanicalEngineering, MajorType._computerScience,
            MajorType._businessManagement, MajorType._geography, MajorType._math, MajorType._marketing, MajorType._chemistry,
            MajorType._economy, MajorType._law, MajorType._computerTechnology];

        public static get Electronics(): string {
            return MajorType._electronics;
        }

        public static get MechanicalEngineering(): string {
            return MajorType._mechanicalEngineering;
        }

        public static get ComputerScience(): string {
            return MajorType._computerScience;
        }

        public static get BusinessManagement(): string {
            return MajorType._businessManagement;
        }

        public static get Geography(): string {
            return MajorType._geography;
        }

        public static get Math(): string {
            return MajorType._math;
        }

        public static get Marketing(): string {
            return MajorType._marketing;
        }
        
        public static get Chemistry(): string {
            return MajorType._chemistry;
        }

        public static get Economy(): string {
            return MajorType._economy;
        }

        public static get Law(): string {
            return MajorType._law;
        }

        public static get ComputerTechnology(): string {
            return MajorType._computerTechnology;
        }

        public static get MajorTypes(): string[] {
            return this._majorTypes;
        }

        public static isMajorTypeValid(majorType: string): boolean {
            if (majorType === null || majorType === '') {
                throw new Error('Major type cannot be null or empty!');
            }

            for (var i = 0; i < MajorType._majorTypes.length; i += 1) {
                if (MajorType._majorTypes[i] === majorType) {
                    return true;
                }
            }

            return false;
        }
    }
}