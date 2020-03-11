(function () {
    'use strict';

    document.getElementById('getSchool').addEventListener("click", getData);

    function getData() {
        var myList = document.querySelector('div');

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
                    var listItem = document.createElement('tr');
                    listItem.innerHTML = '<td>' + json.Skolenheter[i].Skolenhetskod + '</td>';
                    listItem.innerHTML +='<td>' + json.Skolenheter[i].Skolenhetsnamn + '</td>';
                    listItem.innerHTML +='<td>' + json.Skolenheter[i].Kommunkod + '</td>';
                    listItem.innerHTML +='<td>' + json.Skolenheter[i].PeOrgNr + '</td>';
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