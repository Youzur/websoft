(function () {
    'use strict';

    document.getElementById('getSchool').addEventListener("click", getData);

    function getData() {
        var myList = document.querySelector('ul');

        fetch('1290.json')
            .then(function(response) {
                if (!response.ok) {
                    throw new Error("HTTP error, status = " + response.status);
                }
                return response.json();
            })
            .then(function(json) {
                console.log(json);
                document.getElementById('getSchool').style.visibility = 'hidden';
                for(var i = 0; i < json.Skolenheter.length; i++) {
                    var listItem = document.createElement('li');
                    listItem.innerHTML = '<strong>' + json.Skolenheter[i].Skolenhetskod + '</strong>';
                    listItem.innerHTML +='<strong>' + json.Skolenheter[i].Skolenhetsnamn + '</strong>';
                    listItem.innerHTML +='<strong>' + json.Skolenheter[i].Kommunkod + '</strong>';
                    listItem.innerHTML +='<strong>' + json.Skolenheter[i].PeOrgNr + '</strong>';
                    myList.appendChild(listItem);
                }
            })
            .catch(function(error) {
                var p = document.createElement('p');
                p.appendChild(
                    document.createTextNode('Error: ' + error.message)
                );
                document.body.insertBefore(p, myList);
            });
    }

})();