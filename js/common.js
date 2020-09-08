//$(function () {
//    $(document).ready(function () {
//        $(".js-example-placeholder-single").select2({
//            placeholder: "Select",
//            allowClear: true
//        });
//    });
//});

$(document).ready(function () {
    // Single select example if using params obj or configuration seen above
    var configParamsObj = {
        placeholder: 'Select an option...', // Place holder text to place in the select
        minimumResultsForSearch: 3, // Overrides default of 15 set above
        matcher: function (params, data) {
            // If there are no search terms, return all of the data
            if ($.trim(params.term) === '') {
                return data;
            }

            // `params.term` should be the term that is used for searching
            // `data.text` is the text that is displayed for the data object
            if (data.text.toLowerCase().startsWith(params.term.toLowerCase())) {
                var modifiedData = $.extend({}, data, true);
                modifiedData.text += ' ';

                // You can return modified objects from here
                // This includes matching the `children` how you want in nested data sets
                return modifiedData;
            }

            // Return `null` if the term should not be displayed
            return null;
        }
    };
    $(".js-example-placeholder-single").select2(configParamsObj);
});
