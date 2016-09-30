define(['Helper/GlobalVariables' ,'InputData/FamilyMembers', 'MainModules/Family'],function(GlobalVariables, FamilyMembers, Family) {
    function getFamilyMembers() {
        for (var i = 0; i < FamilyMembers.length; i++) {
            GlobalVariables.families.push(new Family(FamilyMembers[i].father, FamilyMembers[i].mother, FamilyMembers[i].children));
        }
    }

    function buildDictionary() {
        var child, childFamily;

        for (var i = 0; i < GlobalVariables.families.length; i++) {
            for (var j = 0; j < GlobalVariables.families[i].getChildren().length; j++) {
                child = GlobalVariables.families[i].getChildren()[j];
                childFamily = findFamily(child);

                if(childFamily === null) {
                    GlobalVariables.families[i].getChildren()[j] = new Family(child);
                }
                else {
                    GlobalVariables.families[i].getChildren()[j] = childFamily;

                    if(child === GlobalVariables.families[i].getChildren()[j].getMother()) {
                        GlobalVariables.families[i].setIsChildFemale(true);
                    }
                }

                GlobalVariables.families[i].getChildren()[j].setHasParents(true);
            }
        }
    }

    function findRoot() {
        getFamilyMembers();
        buildDictionary();

        for (var i = 0; i < GlobalVariables.families.length; i++) {
            if(!GlobalVariables.families[i].getHasParents()) {
                return GlobalVariables.families[i];
            }
        }
    }

    function findFamily(child) {
        for (var i = 0; i < GlobalVariables.families.length; i++) {
            if(GlobalVariables.families[i].getMother() === child || GlobalVariables.families[i].getFather() === child) {
                return GlobalVariables.families[i];
            }
        }

        return null;
    }

    return {
        findRoot: findRoot,
        findFamily: findFamily
    };
});