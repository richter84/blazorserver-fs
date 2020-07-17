var FifeShuttersLtd = FifeShuttersLtd || {};

FifeShuttersLtd.setMultiSelect = function () {
    $(function () {
        console.log("in here");
        $('.selectpicker').selectpicker();

        /*$('.selectpicker').on('change', function (e) {
            console.log("in heresss");
           //dotNetObject.invokeMethodAsync('HandleMultiSelect', this.selectedIndex);
            console.log(this.value, this.options[this.selectedIndex].value, $(this).find("option:selected").val());
        });*/

        $('.selectpicker').on("changed.bs.select",
            function (e, clickedIndex, newValue, oldValue) {

                console.log("in here");
                dotNetObject.invokeMethodAsync('HandleMultiSelect', clickedIndex);
                console.log(this.value, clickedIndex, newValue, oldValue)
            });
    });
}