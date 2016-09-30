define(['MainModules/GlobalConstants'], function(GlobalConst) {
    function getRandomCoordinates(clientParameter) {
        return Math.round((Math.random() * clientParameter - GlobalConst.BLOCK_SIZE) / GlobalConst.BLOCK_SIZE) * GlobalConst.BLOCK_SIZE;
    }

    return {
        getRandomCoordinates: getRandomCoordinates
    }
});