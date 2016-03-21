(function () {
    angular.module('bball', [
        // Global Dependencies
        'ngResource',
        'ui.router',
    ])
      .factory('EntriesService', EntriesService)
      .controller('EntriesController', EntriesController);

    EntriesService.$inject = ['$resource'];

    function EntriesService($resource) {

        var model = this;

        function _getEntries() {
            return $resource('http://localhost:7858/api/entries', {
                id: '@@id'
            }, {
                update: {
                    method: 'PUT'
                }
            });
        }

        function _getPlayers() {
            return $resource('http://localhost:7858/api/players', {
                id: '@@id'
            }, {
                update: {
                    method: 'PUT'
                }
            });
        }

        function _getTeams() {
            return $resource('http://localhost:7858/api/teams', {
                id: '@@id'
            }, {
                update: {
                    method: 'PUT'
                }
            });
        }

        return {
            getEntries: _getEntries,
            getPlayers: _getPlayers,
            getTeams: _getTeams
        };
    }

    EntriesController.$inject = ['EntriesService'];

    function EntriesController(EntriesService) {

        var controller = this;

        // ~~~~~ Public Properties ~~~~~
        controller.entries = [];
        controller.players = [];
        controller.entry = {};
        controller.entry.Player = {};
        controller.entry.Teams = [];
        controller.seedCount = 0;

        // ~~~~~ Public Functions ~~~~~
        controller.getEntries = _getEntries;
        controller.getPlayers = _getPlayers;
        controller.getTeams = _getTeams;
        controller.addEntry = _addEntry;
        controller.teamChange = _teamChange;

        // Initializations
        _initialize();

        // ~~~~~ Private Functions ~~~~~
        function _initialize() {
            _getEntries();
            _getPlayers();
            _getTeams();
        }

        function _teamChange(team) {
            if (controller.entry.Teams.indexOf(team) === -1) {
                if ((controller.seedCount + team.Seed <= 32) && controller.entry.Teams.length < 5) {
                    controller.entry.Teams.push(team);
                    controller.seedCount += team.Seed;
                }
            } else {
                controller.entry.Teams.splice(controller.entry.Teams.indexOf(team), 1);
                controller.seedCount -= team.Seed;
            }
        }

        function _addEntry() {
            EntriesService.getEntries().save(controller.entry).$promise.then(function (data) {
                controller.entries.push(data);
                alert('success');
            });
        }

        function _getEntries() {
            return EntriesService.getEntries().query().$promise.then(function (data) {
                controller.entries = data;
                return controller.entries;
            });
        }

        function _getPlayers() {
            return EntriesService.getPlayers().query().$promise.then(function (data) {
                controller.players = data;
                return controller.players;
            });
        }

        function _getTeams() {
            return EntriesService.getTeams().query().$promise.then(function (data) {
                controller.teams = data;
                return controller.teams;
            });
        }
    }
})();