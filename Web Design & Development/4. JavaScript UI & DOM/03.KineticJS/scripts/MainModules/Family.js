define(function () {
    var Family = (function () {

        function Family(father, mother, children) {
            this.father = father;
            this.mother = mother;
            this.children = children;
            this.hasParenst = false;
            this.isChildFemale = false;
            this.positionX = 200;
            this.positionY = 10;
        }

        Family.prototype.getFather = function() {
            return this.father;
        };

        Family.prototype.getMother = function() {
            return this.mother;
        };

        Family.prototype.getChildren = function() {
            return this.children;
        };

        Family.prototype.getHasParents = function() {
            return this.hasParenst;
        };

        Family.prototype.setHasParents = function(hasParents) {
            this.hasParenst = hasParents;
        };

        Family.prototype.getIsChildFemale = function() {
            return this.isChildFemale;
        };

        Family.prototype.setIsChildFemale = function(isFemale) {
            this.isChildFemale = isFemale;
        };

        Family.prototype.getPositionX = function() {
            return this.positionX;
        };

        Family.prototype.setPositionX = function (x) {
            this.positionX = x;
        };

        Family.prototype.getPositionY = function() {
            return this.positionY;
        };

        Family.prototype.setPositionY = function (y) {
            this.positionY = y;
        };

        Family.prototype.findChild = function(child) {
            for (var i = 0; i < this.children.length; i++) {
                if(this.children[i] === child) {
                    return true;
                }
            }

            return false;
        };

        return Family;
    }());

    return Family;
});