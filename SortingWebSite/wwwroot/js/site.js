// Write your JavaScript code.
function GetMergeSort(id) {
	$.ajax({
		url: "/Home/GetMergeSort",
		type: "get",
		data: { "id": id},
		success: function (data) {
			$("#test").html(data);
		},
		error: function (ex) {
				//Error handling
		}
	})
}
