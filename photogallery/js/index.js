/* On Small Device Start Ticker */

$('#tick2').html($('#tick').html());

var temp = 0,
    intervalId = 0;
$('#tick li').each(function() {
    var offset = $(this).offset();
    var offsetLeft = offset.left;
    $(this).css({
        'left': offsetLeft + temp
    });
    temp = $(this).width() + temp + 10;
});
$('#tick').css({
    'width': temp + 180,
    'margin-left': '20px'
});
temp = 0;
$('#tick2 li').each(function() {
    var offset = $(this).offset();
    var offsetLeft = offset.left;
    $(this).css({
        'left': offsetLeft + temp
    });
    temp = $(this).width() + temp + 10;
});
$('#tick2').css({
    'width': temp + 180,
    'margin-left': temp + 40
});

function abc(a, b) {

    var marginLefta = (parseInt($("#" + a).css('marginLeft')));
    var marginLeftb = (parseInt($("#" + b).css('marginLeft')));
    if ((-marginLefta <= $("#" + a).width()) && (-marginLefta <= $("#" + a).width())) {
        $("#" + a).css({
            'margin-left': (marginLefta - 1) + 'px'
        });
    } else {
        $("#" + a).css({
            'margin-left': temp
        });
    }
    if ((-marginLeftb <= $("#" + b).width())) {
        $("#" + b).css({
            'margin-left': (marginLeftb - 1) + 'px'
        });
    } else {
        $("#" + b).css({
            'margin-left': temp
        });
    }
}

function start() {
    intervalId = window.setInterval(function() {
        abc('tick', 'tick2');
    }, 20)
}

$(function() {
    $('#outer').mouseenter(function() {
        window.clearInterval(intervalId);
    });
    $('#outer').mouseleave(function() {
        start();
    })
    start();
});

/* End Ticker */




/* Start Multiple Item Carousel */
var mod_screen = function() {

    /* Cleanup extra divs that were added in previous resizing  */
    $('.multi_items .item').each(function() {
        $(this).children('div:not(:first)').remove();
    });

    $('.multi_items .item').each(function() {

        var next = $(this).next(),
            i;


        if (Modernizr.mq('(min-width: 768px) and (max-width: 991px)')) {

            /* Small screen sizes */
            if (!next.length) {
                next = $(this).siblings(':first');
            }
            next.children(':first-child').clone().appendTo($(this));

        } else if (Modernizr.mq('(min-width: 992px)')) {

            /* Medium screen sizes */
            if (!next.length) {
                next = $(this).siblings(':first');
            }
            next.children(':first-child').clone().appendTo($(this));

            for (i = 0; i < 1; i++) {
                next = next.next();
                if (!next.length) {
                    next = $(this).siblings(':first');
                }
                next.children(':first-child').clone().appendTo($(this));
            }

        }
    });
}

$(function() {
    // Call on every window resize
    $(window).resize(mod_screen);
    // Call once on initial load
    mod_screen();
});

/* End Multiple Item Carousel */








/* Gallery */
var initPhotoSwipeFromDOM = function(gallerySelector) {

    // parse slide data (url, title, size ...) from DOM elements 
    // (children of gallerySelector)
    var parseThumbnailElements = function(el) {
        var thumbElements = el.childNodes,
            numNodes = thumbElements.length,
            items = [],
            figureEl,
            linkEl,
            size,
            item;

        for(var i = 0; i < numNodes; i++) {

            figureEl = thumbElements[i]; // <figure> element

            // include only element nodes 
            if(figureEl.nodeType !== 1) {
                continue;
            }

            linkEl = figureEl.children[0]; // <a> element

            size = linkEl.getAttribute('data-size').split('x');

            // create slide object
            item = {
                src: linkEl.getAttribute('href'),
                w: parseInt(size[0], 10),
                h: parseInt(size[1], 10)
            };



            if(figureEl.children.length > 1) {
                // <figcaption> content
                item.title = figureEl.children[1].innerHTML; 
            }

            if(linkEl.children.length > 0) {
                // <img> thumbnail element, retrieving thumbnail url
                item.msrc = linkEl.children[0].getAttribute('src');
            } 

            item.el = figureEl; // save link to element for getThumbBoundsFn
            items.push(item);
        }

        return items;
    };

    // find nearest parent element
    var closest = function closest(el, fn) {
        return el && ( fn(el) ? el : closest(el.parentNode, fn) );
    };

    // triggers when user clicks on thumbnail
    var onThumbnailsClick = function(e) {
        e = e || window.event;
        e.preventDefault ? e.preventDefault() : e.returnValue = false;

        var eTarget = e.target || e.srcElement;

        // find root element of slide
        var clickedListItem = closest(eTarget, function(el) {
            return (el.tagName && el.tagName.toUpperCase() === 'FIGURE');
        });

        if(!clickedListItem) {
            return;
        }

        // find index of clicked item by looping through all child nodes
        // alternatively, you may define index via data- attribute
        var clickedGallery = clickedListItem.parentNode,
            childNodes = clickedListItem.parentNode.childNodes,
            numChildNodes = childNodes.length,
            nodeIndex = 0,
            index;

        for (var i = 0; i < numChildNodes; i++) {
            if(childNodes[i].nodeType !== 1) { 
                continue; 
            }

            if(childNodes[i] === clickedListItem) {
                index = nodeIndex;
                break;
            }
            nodeIndex++;
        }



        if(index >= 0) {
            // open PhotoSwipe if valid index found
            openPhotoSwipe( index, clickedGallery );
        }
        return false;
    };

    // parse picture index and gallery index from URL (#&pid=1&gid=2)
    var photoswipeParseHash = function() {
        var hash = window.location.hash.substring(1),
        params = {};

        if(hash.length < 5) {
            return params;
        }

        var vars = hash.split('&');
        for (var i = 0; i < vars.length; i++) {
            if(!vars[i]) {
                continue;
            }
            var pair = vars[i].split('=');  
            if(pair.length < 2) {
                continue;
            }           
            params[pair[0]] = pair[1];
        }

        if(params.gid) {
            params.gid = parseInt(params.gid, 10);
        }

        return params;
    };

    var openPhotoSwipe = function(index, galleryElement, disableAnimation, fromURL) {
        var pswpElement = document.querySelectorAll('.pswp')[0],
            gallery,
            options,
            items;

        items = parseThumbnailElements(galleryElement);

        // define options (if needed)
        options = {

            // define gallery index (for URL)
            galleryUID: galleryElement.getAttribute('data-pswp-uid'),

            getThumbBoundsFn: function(index) {
                // See Options -> getThumbBoundsFn section of documentation for more info
                var thumbnail = items[index].el.getElementsByTagName('img')[0], // find thumbnail
                    pageYScroll = window.pageYOffset || document.documentElement.scrollTop,
                    rect = thumbnail.getBoundingClientRect(); 

                return {x:rect.left, y:rect.top + pageYScroll, w:rect.width};
            }

        };

        // PhotoSwipe opened from URL
        if(fromURL) {
            if(options.galleryPIDs) {
                // parse real index when custom PIDs are used 
                // http://photoswipe.com/documentation/faq.html#custom-pid-in-url
                for(var j = 0; j < items.length; j++) {
                    if(items[j].pid == index) {
                        options.index = j;
                        break;
                    }
                }
            } else {
                // in URL indexes start from 1
                options.index = parseInt(index, 10) - 1;
            }
        } else {
            options.index = parseInt(index, 10);
        }

        // exit if index not found
        if( isNaN(options.index) ) {
            return;
        }

        if(disableAnimation) {
            options.showAnimationDuration = 0;
        }

        // Pass data to PhotoSwipe and initialize it
        gallery = new PhotoSwipe( pswpElement, PhotoSwipeUI_Default, items, options);
        gallery.init();
    };

    // loop through all gallery elements and bind events
    var galleryElements = document.querySelectorAll( gallerySelector );

    for(var i = 0, l = galleryElements.length; i < l; i++) {
        galleryElements[i].setAttribute('data-pswp-uid', i+1);
        galleryElements[i].onclick = onThumbnailsClick;
    }

    // Parse URL and open gallery if it contains #&pid=3&gid=1
    var hashData = photoswipeParseHash();
    if(hashData.pid && hashData.gid) {
        openPhotoSwipe( hashData.pid ,  galleryElements[ hashData.gid - 1 ], true, true );
    }
};

// execute above function
initPhotoSwipeFromDOM('.gallery_1');
/* End Gallery */