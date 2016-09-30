define(['MainModules/GlobalConstants', 'MainModules/Stone', 'Helper/RandomGenerator',
    'MainModules/Position'] ,function(GlobalConst, Stone, RandomGenerator, Position) {

    var food = createFood();
    var foodCoordinates = createCoordinates();

    function createFood() {
        food = new Image();
        food.src = 'images/apple.png';
        food.width = GlobalConst.BLOCK_SIZE;
        food.height = GlobalConst.BLOCK_SIZE;

        return food;
    }

    function createCoordinates() {
        var foodCoordinateX;
        var foodCoordinateY;

        while(true) {
            foodCoordinateX = RandomGenerator.getRandomCoordinates(GlobalConst.CANVAS.clientWidth);
            foodCoordinateY = RandomGenerator.getRandomCoordinates(GlobalConst.CANVAS.clientHeight);

            if(areFoodCoordinatesValid(foodCoordinateX, foodCoordinateY)) {
                break;
            }
        }

        return new Position(foodCoordinateX, foodCoordinateY);
    }

    function areFoodCoordinatesValid(foodCoordinateX, foodCoordinateY){
        if(foodCoordinateX < 0 || foodCoordinateY < 0 ||
            foodCoordinateX > GlobalConst.CANVAS.clientWidth || foodCoordinateY > GlobalConst.CANVAS.clientHeight) {
            return false;
        }

        if(foodCoordinateX <= GlobalConst.BLANK_POSITION.x && foodCoordinateY <= GlobalConst.BLANK_POSITION.y) {
            return false;
        }

        for (var i = 0; i < Stone.stonesCoordinates.length; i++) {
            if(foodCoordinateX === Stone.stonesCoordinates[i].x && foodCoordinateY === Stone.stonesCoordinates[i].y) {
                return false;
            }
        }

        return true;
    }

    function generateNewCoordinates() {
        this.foodCoordinates = createCoordinates();
    }

    return {
        food: food,
        foodCoordinates: foodCoordinates,
        generateNewCoordinates: generateNewCoordinates
    };
});
