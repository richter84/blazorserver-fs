var FifeShuttersLtd = FifeShuttersLtd || {};

FifeShuttersLtd.setSignature = function (data, dotNetObject) {
    console.log("in here too");
    var canvas = document.querySelector('canvas');

    var signaturePad = new SignaturePad(canvas);

    signaturePad.fromDataURL(data);
    var ratio = Math.max(window.devicePixelRatio || 1, 1);
    canvas.width = canvas.offsetWidth * ratio;
    canvas.height = canvas.offsetHeight * ratio;
    canvas.getContext("2d").scale(ratio, ratio);
    console.log(window.devicePixelRatio);
    var clearButton = document.getElementById('clear');

    canvas.addEventListener('mouseup', function (event) {
        var dataURL = signaturePad.toDataURL();
        dotNetObject.invokeMethodAsync('AddSignature', dataURL.toString());
    });

    clearButton.addEventListener('click', function (event) {
        signaturePad.clear();
    });
}