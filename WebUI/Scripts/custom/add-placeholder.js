
//Adds placeholder text to fields

    $(document).ready(function () {
        $(".set-placeholder").each(function () {
            $(this).find("input").attr("placeholder", $(".placeholder-Text").first().val());
        })
    });