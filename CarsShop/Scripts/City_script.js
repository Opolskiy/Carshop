

                                        var dataObject = {
                                            "null": "",

                                            "Беларусь": ",Минск,Брест,Могилев,Гродно,Гомель,Витебск",

                                            "Германия": ",Берлин,Вольфсбург,Мюнхен,Гамбург",

                                            "Россия": ",Москва,Санкт-Питербург,Смоленск,Тольяти",

                                            "Польша": ",Варшава,Бяла-Подляска",

                                            "Литва": ",Вильнюс,Каунас",

                                            "Украина": ",Львов,Киев"

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

makeRelation(gid("country"), gid("town"), dataObject); // Использование

function gid(txt) {

    return document.getElementById(txt);

}

