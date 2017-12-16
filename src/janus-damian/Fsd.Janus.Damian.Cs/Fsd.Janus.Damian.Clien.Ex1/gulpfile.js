'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');
var rename = require('gulp-rename');


gulp.task('sass', function () {
 return gulp.src('./styles/*.scss')
   .pipe(sass({outputStyle: 'compressed'}).on('error', sass.logError))
   .pipe(rename('style.min.css'))
   .pipe(gulp.dest('./styles'));
});

gulp.task('sass:watch', function () {
 gulp.watch('./styles/*.scss', ['sass']);
});