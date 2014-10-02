function ClearSearchForm() {
    $('#Mark').val("");
    $('#Series').val("");
    $('#BodyType').val("");
    $('#FuelType').val("");
    $('#Transmission').val("");
    $('#Price_min').val("");
    $('#Price_max').val("");
    $('#Year_min').val("");
    $('#Year_max').val("");
    $('#country').val("");
    $('#town').val("");
    $('#Drive').val("");
    $('#Color').val("");
    $('#Distance_min').val("");
    $('#Distance_max').val("");
    $("input:checkbox").removeAttr("checked");    
}