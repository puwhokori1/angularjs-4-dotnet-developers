module.exports = function(grunt) {
	grunt.initConfig({
		clean: {
			options: {force: true},
			all: {
				src: ['../Registrator/app_built/**/*.*']
			}
		},
		
		ngmin: {
			all: {
				files: [
					{
						expand: true,
						cwd: '../Registrator/app',
						src: ['**/*.js'],
						dest: '../Registrator/app_built/',
						ext: '.js'
					}
				]
			}
		},
		
				
	});


	grunt.registerTask('default', ['build']);
	grunt.registerTask('build', ['clean', 'ngmin']);

	grunt.loadNpmTasks('grunt-contrib-clean');
	grunt.loadNpmTasks('grunt-ngmin');
};