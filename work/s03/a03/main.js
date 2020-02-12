(function () {
    'use strict';

    document.getElementById('getSchool').addEventListener("click", getData);

    /*function getData() {
        fetch('data/1290.json')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                let output = '<h2>Schools</h2>';
                data.Skolenheter.forEach(function (school) {
                    output += `
                    <ul>
                        <li>Skolenhetskod: ${school.Skolenhetskod}</li>
                        <li>Skolenhetsnamn: ${school.Skolenhetsnamn}</li>
                        <li>Kommunkod: ${school.Kommunkod}</li>
                        <li>PeOrgNr: ${school.PeOrgNr}</li>
                    </ul>
                    `;
                });
                document.getElementById('output').innerHTML = output;
            })
    }*/

    // UPDATE 1
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