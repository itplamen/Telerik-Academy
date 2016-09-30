(function() {
    require.config({
        paths: {
            'kinetic' : 'libs/kinetic-v5.1.0.min',
            'raphael' : 'libs/raphael-min',
            'GlobalConstants': 'Helper/GlobalConstants',
            'SuperMario': 'Modules/SuperMario',
            'GameEngine': 'Controllers/GameEngine'
        }
    });

    require(['GameEngine'], function(GameEngine) {
        GameEngine.startGame();
    });
}());