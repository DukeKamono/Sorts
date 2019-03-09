function GetMergeSort() {

	var radio = document.querySelector('input[name="radioButtons"]:checked');
	var size = document.querySelector('input[name="listSize"]');
	var iterations = document.querySelector('input[name="iterations"]');

	if (radio) {
		$.ajax({
			url: "/Home/GetMergeSort",
			type: "get",
			data: {
				"inputType": radio.value, "inputSize": size.value, "repeatAmount": iterations.value},
			success: function (data) {
				var randomColor = GetRandomColor();
				data.forEach(function(e) {
					$("#ResultTime").append("<p style=\"color: " + randomColor +"\">" + e.resultTime + "</p>");
					$("#SortedArray").append("<p style=\"color: " + randomColor +"\">" + e.sortedArray + "</p>");
					$("#BegginingArray").append("<p style=\"color: " + randomColor +"\">" + e.begginingArray + "</p>");
				});

				$("#Error").css("display", "none");
			},
			error: function () {
				$("#Error").html("Something went wrong! Try again.");
				$("#Error").css("display", "block");
				$("#Error").css("color", "red");
				//Error handling
			}
		});
	}
	else {
		$("#Error").css("display", "block");
		$("#Error").css("color", "red");
	}
}

//Maybe later combine these two sort functions and just pass in a radio value or something on one page.
function GetQuickSort() {

	var radio = document.querySelector('input[name="radioButtons"]:checked');
	var size = document.querySelector('input[name="listSize"]');
	var iterations = document.querySelector('input[name="iterations"]');

	if (radio) {
		$.ajax({
			url: "/Home/GetQuickSort",
			type: "get",
			data: {
				"inputType": radio.value, "inputSize": size.value, "repeatAmount": iterations.value
			},
			success: function (data) {
				var randomColor = GetRandomColor();
				data.forEach(function (e) {
					$("#ResultTime").append("<p style=\"color: " + randomColor + "\">" + e.resultTime + "</p>");
					$("#SortedArray").append("<p style=\"color: " + randomColor + "\">" + e.sortedArray + "</p>");
					$("#BegginingArray").append("<p style=\"color: " + randomColor + "\">" + e.begginingArray + "</p>");
				});

				$("#Error").css("display", "none");
			},
			error: function () {
				$("#Error").html("Something went wrong! Try again.");
				$("#Error").css("display", "block");
				$("#Error").css("color", "red");
				//Error handling
			}
		});
	}
	else {
		$("#Error").css("display", "block");
		$("#Error").css("color", "red");
	}
}

function GetHeapSort() {

	var radio = document.querySelector('input[name="radioButtons"]:checked');
	var size = document.querySelector('input[name="listSize"]');
	var iterations = document.querySelector('input[name="iterations"]');

	if (radio) {
		$.ajax({
			url: "/Home/GetHeapSort",
			type: "get",
			data: {
				"inputType": radio.value, "inputSize": size.value, "repeatAmount": iterations.value
			},
			success: function (data) {
				var randomColor = GetRandomColor();
				data.forEach(function (e) {
					$("#ResultTime").append("<p style=\"color: " + randomColor + "\">" + e.resultTime + "</p>");
					$("#SortedArray").append("<p style=\"color: " + randomColor + "\">" + e.sortedArray + "</p>");
					$("#BegginingArray").append("<p style=\"color: " + randomColor + "\">" + e.begginingArray + "</p>");
				});

				$("#Error").css("display", "none");
			},
			error: function () {
				$("#Error").html("Something went wrong! Try again.");
				$("#Error").css("display", "block");
				$("#Error").css("color", "red");
				//Error handling
			}
		});
	}
	else {
		$("#Error").css("display", "block");
		$("#Error").css("color", "red");
	}
}

function Clear() {
	$("#ResultTime").html("<p>Time Here:</p>");
	$("#SortedArray").html("<p>Sorted Array:</p>");
	$("#BegginingArray").html("<p>Beggining Array:</p>");
}

//https://stackoverflow.com/questions/1484506/random-color-generator
function GetRandomColor() {
	var letters = '0123456789ABCDEF';
	var color = '#';
	for (var i = 0; i < 6; i++) {
		color += letters[Math.floor(Math.random() * 16)];
	}
	return color;
}
