function initializeTable() {
    createRow('Bulgaria', 'Sofia');
    createRow('Germany', 'Berlin');
    createRow('Russia', 'Moscow');

    $('#createLink').click(create);


    function create() {
        let country = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        createRow(country, capital);
        $('#newCountryText').val('');
        $('#newCapitalText').val('');
        fixRowLinks();
    }

    function createRow(country, capital) {
        let row = $('<tr>')
            .append($("<td>").text(country))
            .append($("<td>").text(capital))
            .append($("<td>")
                .append($("<a href='#'>[Up]</a>").click(moveRowUp))
                .append(" ")
                .append($("<a href='#'>[Down]</a>").click(moveRowDown))
                .append(" ")
                .append($("<a href='#'>[Delete]</a>").click(deleteRow)));
        row.css('display','none');
        $("#countriesTable").append(row);
        row.fadeIn();
        fixRowLinks();
    }

    function moveRowUp() {
        let row = $(this).parent().parent();
        row.fadeOut(function() {
            row.insertBefore(row.prev());
            row.fadeIn();
            fixRowLinks();
        });

    }

    function moveRowDown() {
        let row = $(this).parent().parent();
        row.fadeOut(function() {
            row.insertAfter(row.next());
            row.fadeIn();
            fixRowLinks();
        });

    }

    function deleteRow() {
        let row = $(this).parent().parent();
        row.fadeOut(function() {
            row.remove();
            fixRowLinks();
        });

    }

    function fixRowLinks() {
        $('#countriesTable a').css('display', 'inline');

        let tableRows = $('#countriesTable tr');
        $(tableRows[2]).find("a:contains('Up')")
            .css('display', 'none');

        $(tableRows[tableRows.length - 1]).find("a:contains('Down')")
            .css('display', 'none');

    }
}