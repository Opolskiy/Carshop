function ClearSearchForm() {
    $('#Mark').val("");
    $('#Series').val("");
    $('#BodyType').val("");
    $('#FuelType').val("");
    $('#Transmission').val("");
    $('#price_min').val("");
    $('#price_max').val("");
    $('#age_min').val("");
    $('#age_max').val("");
    $('#country').val("");
    $('#town').val("");
    $('#Drive').val("");
    $('#Color').val("");
    $('#distance_min').val("");
    $('#distance_max').val("");
    $("input:checkbox").removeAttr("checked");
}