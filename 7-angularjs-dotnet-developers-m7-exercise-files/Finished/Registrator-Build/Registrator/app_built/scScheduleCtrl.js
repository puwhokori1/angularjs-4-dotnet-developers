angular.module('app').controller('scScheduleCtrl', [
  '$scope',
  'notifier',
  function ($scope, notifier) {
    $scope.unregisterCourse = function (course) {
      course.registered = false;
      notifier.notify('You have unregistered for ' + course.name);
    };
  }
]);