app.value('followedInstructors', [
  { id: 1, name: 'Professor Snape' },
  { id: 2, name: 'Professor McGonagall' },
  { id: 3, name: 'Professor Dumbledore' }
]);

app.value('currentUser', currentUser);

app.factory('catalog', function($http) {
	return {
		query: function() {
			var result = [];

			$http.post('/DataService.asmx/GetCourses', {}).then(function(response) {
				result.length = 0;
				response.data.d.forEach(function(item) {
					result.push(item);
				});
			});

			return result;
		},
		
		updateCourse: function(course) {
			$http.post('/DataService.asmx/UpdateCourse',
				{ id: course.id, registered: course.registered });
		}
	}
})

app.factory('catalog-old', function($resource, $http) {
	return $resource('', undefined, {
		query: {
			method: 'POST',
			url: '/DataService.asmx/GetCourses',
			isArray: true,
			transformResponse: [
				function(data) {
					return JSON.parse(data).d;
				}
			].concat($http.defaults.transformResponse)
		},
		save: {
			method: 'POST',
			url: '/DataService.asmx/UpdateCourse'
		}
	});
})