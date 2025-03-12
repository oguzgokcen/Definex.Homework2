// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {

    const $searchInput = $('#searchbar');
    const $searchResults = $('.search-results');
    const $searchButtons = $('.search-buttons');

    // Function to show search results
    function showResults(query) {
        if (!query) {
            $searchResults.hide();
            $searchButtons.show();
            return;
        }

        var data = {
            searchTerm: query
        };


        $.ajax({
            method: "GET",
            url: $('#SearchUrl').val(),
            data: data
        }).done(function (response) {
            if (response.isSuccess) {
                var resultsHTML = ''
                response.data.forEach(result => {
                    resultsHTML += `
                      <div class="result-item">
                        <div class="result-title">${result.productName}</div>
                        <div class="result-description">${result.productDesc}</div>
                      </div>
                    `;
                });

                $searchResults.html(resultsHTML);
                $searchResults.show();
                $searchButtons.hide();
            } else {
                $searchResults.hide();
                return;
            }

        })

    }

    $searchInput.on('input', function () {
        const query = $(this).val().trim();

        showResults(query);
    });

    $searchResults.on('click', function (e) {
        e.stopPropagation();
    });

    $(document).on('click', '.result-item', function () {
        const title = $(this).find('.result-title').text();
        $searchInput.val(title);
        $searchResults.hide();
        alert('Seçiminiz: ' + title);
    });
});