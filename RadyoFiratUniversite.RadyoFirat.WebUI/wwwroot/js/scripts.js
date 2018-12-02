/*----------------------------------------------------*/
/* MOBILE DETECT FUNCTION
 /*----------------------------------------------------*/
var isMobile = {
  Android: function() {
    return navigator.userAgent.match(/Android/i);
  },
  BlackBerry: function() {
    return navigator.userAgent.match(/BlackBerry/i);
  },
  iOS: function() {
    return navigator.userAgent.match(/iPhone|iPad|iPod/i);
  },
  Opera: function() {
    return navigator.userAgent.match(/Opera Mini/i);
  },
  Windows: function() {
    return navigator.userAgent.match(/IEMobile/i);
  },
  any: function() {
    return (isMobile.Android() || isMobile.BlackBerry() || isMobile.iOS() || isMobile.Opera() || isMobile.Windows());
  }
};



/////////////////////// ready
$(document).on('ready', function() {
  "use strict";


  $("#load").fadeOut( 200, function() {
    $(this).remove();
  });

  /*----------------------------------------------------*/
  // Camera slideshow
  /*----------------------------------------------------*/
  var oa = $('#camera_wrap');
  if (oa.length > 0) {
    oa.camera({
      //thumbnails: true
      alignment     : 'centerTop',
      autoAdvance     : true,
      mobileAutoAdvance : true,
      // fx          : 'scrollRight',
      height: '51%',
      hover: false,
      loader: 'none',
      navigation: false,
      navigationHover: false,
      mobileNavHover: false,
      playPause: false,
      pauseOnClick: false,
      pagination      : true,
      time: 5000,
      transPeriod: 1000,
      minHeight: '300px'
    });
  }

  /*----------------------------------------------------*/
  // player.
  /*----------------------------------------------------*/

  MediaElementPlayer.prototype.prevbuilder = function(player, controls, layers, media){
    var prevbut = $('<div class="mejs-button mejs-previous-button mejs-cust1-button">' +
        '</div>')
      // append it to the toolbar
        .appendTo(controls)
      // add a click toggle event
        .click(function(){
          // window.open(player.options.logo.link, '_blank');
          player.options.prevFunc.apply(this);
        });
  };



  MediaElementPlayer.prototype.buildcust3 = function(player, controls, layers, media) {
    var
        cust3 =
            $('<div class="mejs-button mejs-cust3-button "><button></button></div>')
              // append it to the toolbar
                .appendTo(controls);
  };

  MediaElementPlayer.prototype.buildcust4 = function(player, controls, layers, media) {
    var
        cust4 =
            $('<div class="mejs-button mejs-cust4-button "><button></button></div>')
              // append it to the toolbar
                .appendTo(controls);
  };




  if($('body').find('.liveRadio').length !== 0) {
      $('#audio4_html5_white').audio4_html5({
          playerWidth:1200,
          skin: 'whiteControllers',
          initialVolume:0.5,
          responsive:false,
          showPlaylistOnInit:false,
          showCategories:false,
          showSearchArea:false
      });
  }



  $('.audio1 audio').mediaelementplayer({
    //features: ['cust1','playpause','cust2','progress','current','duration','cust3','cust4','volume']
    features: ['playlistfeature', 'prevtrack', 'playpause', 'nexttrack', 'progress', 'current', 'volume']
  });

  $('.audio2 audio').mediaelementplayer({
    features: ['playpause','progress']
  });



  $('.mejs-prevtrack-button').addClass('mejs-cust1-button');
  $('.mejs-nexttrack-button').addClass('mejs-cust2-button');


  /*----------------------------------------------------*/
  // carouFredSel.
  /*----------------------------------------------------*/
  var ob = $('#testim').find('.carousel.main ul');
  if (ob.length > 0) {
    ob.carouFredSel({
      auto: {
        timeoutDuration: 8000
      },
      responsive: true,
      // prev: '.popular_prev',
      // next: '.popular_next',
      pagination: '.testim_pagination',
      width: '100%',
      scroll: {
        // fx : "crossfade",
        items: 1,
        duration: 1000,
        easing: "easeOutExpo"
      },
      items: {
        width: '1000',
        height: 'variable', //  optionally resize item-height
        visible: {
          min: 1,
          max: 1
        }
      },
      mousewheel: false,
      swipe: {
        onMouse: true,
        onTouch: true
      }
    });
  }

  $(window).on("resize",updateSizes_vat).on("load",updateSizes_vat);
  function updateSizes_vat(){
    $('#testim').find('.carousel.main ul').trigger("updateSizes");


  }
  updateSizes_vat();


  /*----------------------------------------------------*/
  // Sticky.
  /*----------------------------------------------------*/
  $("#top2").sticky({
    topSpacing:0,
    getWidthFrom: 'body',
    responsiveWidth: true
  });

  /*----------------------------------------------------*/
  // PRELOADER CALLING
  /*----------------------------------------------------*/
  $("body.onepage").queryLoader2({
    //barColor: "#fff",
    //backgroundColor: "#000",
    percentage: true,
    barHeight: 3,
    completeAnimation: "fade",
    minimumTime: 200
  });



  /*----------------------------------------------------*/
  // MENU SMOOTH SCROLLING
  /*----------------------------------------------------*/
  $(".navbar_ .nav a, .menu_bot a, .scroll-to").on('click',function(event){

    //$(".navbar_ .nav a a").removeClass('active');
    //$(this).addClass('active');
    // var headerH = $('#top1').outerHeight();
    var headerH = $('#top2').outerHeight();

    if ($(this).attr("href")=="#home") {
      $("html, body").animate({
        scrollTop: 0 + 'px'
        // scrollTop: $($(this).attr("href")).offset().top + 'px'
      }, {
        duration: 1200,
        easing: "easeInOutExpo"
      });
    }
    else {
      $("html, body").animate({
        scrollTop: $($(this).attr("href")).offset().top - headerH + 'px'
        // scrollTop: $($(this).attr("href")).offset().top + 'px'
      }, {
        duration: 1200,
        easing: "easeInOutExpo"
      });
    }



    event.preventDefault();
  });

  /*----------------------------------------------------*/
  // Slick
  /*----------------------------------------------------*/
  $('.slick-slider').slick({
    centerMode: true,
    centerPadding: '0px',
    slidesToShow: 3,
    autoplay: true,
    autoplaySpeed: 7000,
    responsive: [
      {
        breakpoint: 2700,
        settings: {
          arrows: true,
          centerMode: true,
          centerPadding: '0px',
          slidesToShow: 3
        }
      },
      {
        breakpoint: 767,
        settings: {
          arrows: true,
          centerMode: true,
          centerPadding: '150px',
          slidesToShow: 1
        }
      },
      {
        breakpoint: 600,
        settings: {
          arrows: true,
          centerMode: true,
          centerPadding: '20px',
          slidesToShow: 1
        }
      }
    ]
  });

  /*----------------------------------------------------*/
  // Appear
  /*----------------------------------------------------*/
  $('.animated').appear(function() {
    // console.log("111111111111");
    var elem = $(this);
    var animation = elem.data('animation');
    if ( !elem.hasClass('visible') ) {
      var animationDelay = elem.data('animation-delay');
      if ( animationDelay ) {
        setTimeout(function(){
          elem.addClass( animation + " visible" );
        }, animationDelay);
      } else {
        elem.addClass( animation + " visible" );
      }
    }
  });

  /////// jrumble
  $('.speaker-img').find("img").jrumble({
    x: 1,
    y: 1,
    rotation: 2,
    speed: 30,
    opacity: true,
    opacityMin: .05
  }).trigger('startRumble');
  
  
  function setter() {
    var winWidth = $(window).width();
    var gavy = parseInt(winWidth)+15;
    if(gavy < 992 && gavy > 767) {
        var mina = gavy/2;
        var min = mina+170;
    }
    else if (gavy < 768) {
        var min = gavy-210;
    }
    else {
        var yop = gavy/2;
        var min = yop-190;
    }


    if(gavy < 1200) {
        $('.VolumeSlider').css('width',min);
    }
    else {
        $('.VolumeSlider').css('width','468px');
    }

  }
  
  
  setTimeout(function() {
    setter();
  }, 100);
  
  $(window).resize(function() {
      setter();
  });



});

