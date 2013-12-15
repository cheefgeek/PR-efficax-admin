
//Handles button clicks for standard buttons below grid on each entity search page


// Disable edit button by default
$("#btnEdit").attr("disabled", "disabled");

// Disable delete button by default
$("#btnDelete").attr("disabled", "disabled");




var editUrl = null;
var deleteUrl = null;

function showDetails(e) {
    grid = e.sender;

    // Get selected row 
    var currentDataItem = grid.dataItem(this.select());

    //Enable/Disable button
    if (currentDataItem !== null && currentDataItem.id.toString().length > 0) {
        $("#btnEdit").removeAttr("disabled");
        $("#btnDelete").removeAttr("disabled");

        editUrl = controller + '/Edit/' + currentDataItem.id;
        deleteUrl = controller + '/Delete/' + currentDataItem.id;
    }
    else {
        $("#btnEdit").attr("disabled", "disabled");
        $("#btnDelete").attr("disabled", "disabled");
        editUrl = null;
        deleteUrl = null;
    }
}

$("#btnEdit").on("click", function () {
    window.location.href = editUrl;
})

$("#btnNew").on("click", function () {
    window.location.href = controller + '/Create';
})

$(".move_to").on("click", function (e) {
    e.preventDefault();
    $("#deleteForm").attr("action", deleteUrl);
    $("#deleteForm").submit();
});
