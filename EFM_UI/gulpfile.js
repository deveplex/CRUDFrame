/// <binding AfterBuild='publish:project, publish:plugins, build:project' Clean='clean' ProjectOpened='watch' />



var gulp = require('gulp'),
    $ = require('gulp-load-plugins')(),
    pkg = require('./package.json');

var optionset = {
    banner: [
    ].join('\n'),
    less: [],
    jsx: [],
    clean: [],
    publish:[]
};

gulp.task('watch', function () {

    var css = [
        './Libs/project/css/**/*.css'
    ];
    var js = [
        './Libs/project/js/**/*.js'
    ];

    //gulp.src(css)
    //    .pipe(gulp.dest('./Content'));
    gulp.src(js)
        .pipe($.jshint())
        .pipe($.jshint.reporter('default'))
});

gulp.task('clean', function () {
    gulp.src('./Content/*')
    .pipe($.clean());
    gulp.src('./Scripts/*')
    .pipe($.clean());
    gulp.src('./Themes/*')
    .pipe($.clean());

});

gulp.task('build:project', function () {

    var css = [
        './Libs/project/css/**/*.css'
    ];
    var js = [
        './Libs/project/js/**/*.js'
    ];

    gulp.src(css)
        .pipe(gulp.dest('./Content'));
    gulp.src(js)
        .pipe(gulp.dest('./Scripts'));
});

gulp.task('publish:project', function () {

    var css = [
        './Libs/project/css/**/*.css'
    ];
    var js = [
        './Libs/project/js/**/*.js'
    ];

    gulp.src(css)
        .pipe($.rename({ suffix: '.min' }))
        .pipe($.cssmin())
        .pipe($.header(optionset.banner, { pkg: pkg }))
        .pipe(gulp.dest('./Content'));
    gulp.src(js)
        .pipe($.rename({ suffix: '.min' }))
        .pipe($.uglify())
        .pipe($.header([optionset.banner].join('\n'), { pkg: pkg }))
        .pipe(gulp.dest('./Scripts'));
});

gulp.task('publish:plugins', function () {

    var css = [
        './Libs/bootstrap/dist/css/bootstrap.min.css',
        './Libs/bootstrap-xclusive/dist/css/bootstrap.xclusive.min.css'
    ];
    var js = [
        //'./Libs/jquery/dist/jquery.js',
        './Libs/jquery/dist/jquery.min.js',
        //'./Libs/jquery-validation/dist/jquery.validate.js',
        './Libs/jquery-validation/dist/jquery.validate.min.js',
        './Libs/bootstrap/dist/js/bootstrap.min.js',
        './Libs/bootstrap-xclusive/dist/js/bootstrap.xclusive.min.js',
        './Libs/jquery.easyui/jquery.easyui.min.js',
        './Libs/modernizr/src/Modernizr.js',
        //'./Libs/respond/dest/respond.src.js',
        './Libs/respond/dest/respond.min.js'
    ];
    var fonts = [
        './Libs/bootstrap/dist/fonts/*.*',
        './Libs/bootstrap-xclusive/dist/fonts/*.*'
   ];
    var themes = [
        './Libs/jquery.easyui/themes/*.*',
        './Libs/jquery.easyui/themes/**/easyui.*',
         './Libs/jquery.easyui/themes/**/images/*.*',
         './Libs/jquery.easyui/themes/**/icons/*.*',
  ];
    gulp.src(css)
        .pipe(gulp.dest('./Content'));
     gulp.src(js)
        .pipe(gulp.dest('./Scripts'));
     gulp.src(fonts)
         .pipe(gulp.dest('./fonts'));
   gulp.src(themes)
        .pipe(gulp.dest('./Themes'));
});