

var dataObject = {
    "": "",

    "Audi": ",A1,S1,A3,S3,RS3,A4,S4,RS4,A5,S5,RS5,A6,A7,S7,A8,RS7,Q3",

    "BMW": ",1,2,3,M3,4,M4,5,M5,6,7,X1,X3,X4,X5,X6",

    "Citroen": ",C-Zero,C1,C2,C3,C4,C5,C6,DS3,DS4,DS5,Berlingo,Nemo,Jumper",

    "Ford": ",B-Max,C-Max,Fiesta,Focus,Fusion,Mondeo,S-Max",

    "Gelly": ",Emgrand 7,Emgrand 8,Emgrand X7,CK,MK,GS6,GX7,SX7,GC7",

    "Hodna": ",Accord,Civic,CR-V,Crosstour,Element,FR-V,Insight,Jazz"

};

makeRelation = (function () {

    function change(slave, data) {

        var x, dataArray, option;

        slave.innerHTML = "";

        if (!(this.value in data)) {

            return false;

        }

        dataArray = data[this.value].split(",");

        for (x = 0; x < dataArray.length; x++) {

            option = document.createElement("option");

            option.value = dataArray[x];

            option.innerHTML = dataArray[x];

            slave.appendChild(option);

        }

    }

    return function (master, slave, data) {

        master.onchange = function () {

            change.call(this, slave, data);

        }

        master.onchange();

    }

})();

makeRelation(gid("Mark"), gid("Series"), dataObject); // Использование

function gid(txt) {

    return document.getElementById(txt);

}