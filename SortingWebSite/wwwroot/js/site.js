// Write your JavaScript code.
function GetMergeSort() {

	var radio = document.querySelector('input[name="radioButtons"]:checked');
	var size = document.querySelector('input[name="listSize"]');

	if (radio) {
		$.ajax({
			url: "/Home/GetMergeSort",
			type: "get",
			data: { "inputType": radio.value, "inputSize": size.value },
			success: function (data) {
				$("#ResultTime").html(data.resultTime);
				$("#SortedArray").html(data.sortedArray);
				$("#BegginingArray").html(data.begginingArray);
				$("#Error").css("display", "none");
			},
			error: function (ex) {
				alert(ex);
				$("#Error").html(data);
				$("#Error").css("display", "block");
				$("#Error").css("color", "red");
				//Error handling
			}
		})
	}
	else {
		$("#Error").css("display", "block");
		$("#Error").css("color", "red");
	}
}
