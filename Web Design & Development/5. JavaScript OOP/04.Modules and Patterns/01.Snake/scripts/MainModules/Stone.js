define(['MainModules/GlobalConstants', 'MainModules/Position', 'Helper/RandomGenerator'], function(GlobalConst, Position, RandomGenerator) {
    var stones = [];
    var stonesCoordinates = [];

    createStones(stones);
    createCoordinates(stonesCoordinates);

    function createStones(stones) {
        for (var i = 0; i < GlobalConst.NUMBER_OF_STONES; i++) {
            stones.push(new Image());
            stones[i].src = 'images/stone.png';
            stones[i].width = GlobalConst.BLOCK_SIZE;
            stones[i].height = GlobalConst.BLOCK_SIZE;
        }
    }

    function createCoordinates(stonesCoordinates){
        var stoneCoordinateX;
        var stoneCoordinateY;

        for (var i = 0; i < GlobalConst.NUMBER_OF_STONES; i++) {
            while(true) {
                stoneCoordinateX = RandomGenerator.getRandomCoordinates(GlobalConst.CANVAS.clientWidth);
                stoneCoordinateY = RandomGenerator.getRandomCoordinates(GlobalConst.CANVAS.clientHeight);

                if(areStoneCoordinatesValid(stoneCoordinateX, stoneCoordinateY, stonesCoordinates)) {
                    stonesCoordinates.push(new Position(stoneCoordinateX, stoneCoordinateY));
                    break;
                }
            }
        }
    }

    function areStoneCoordinatesValid(stoneCoordinateX, stoneCoordinateY, stonesCoordinates) {
        if(stoneCoordinateX < 0 || stoneCoordinateY < 0 ||
            stoneCoordinateX > GlobalConst.CANVAS.clientWidth || stoneCoordinateY > GlobalConst.CANVAS.clientHeight) {
            return false;
        }

        if(stoneCoordinateX <= GlobalConst.BLANK_POSITION.x && stoneCoordinateY <= GlobalConst.BLANK_POSITION.y) {
            return false;
        }

        for (var i = 0; i < stonesCoordinates.length; i++) {
            if(stoneCoordinateX === stonesCoordinates[i].x && stoneCoordinateY === stonesCoordinates[i].y) {
                return false;
            }
        }

        return true;
    }

    return {
        stones: stones,
        stonesCoordinates: stonesCoordinates
    };
});