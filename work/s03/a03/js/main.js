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

    function getData() {
        var myList = document.querySelector('ul');
        fetch('data/1290.json')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                //document.getElementById("table").innerHTML = JSON.stringify(data);

                for(var i = 0; i < data.length; i++) {
                    var listItem = document.createElement('li');
                    listItem.innerHTML = '<strong>' + data[i] + '</strong>';
                //    listItem.innerHTML += '<strong>' + json.Skolenheter[i].Skolenhetsnamn + '</strong>';
                 //   listItem.innerHTML += '<strong>' + json.Skolenheter[i].Kommunkod + '</strong>';
                 //   listItem.innerHTML += '<strong>' + json.Skolenheter[i].PeOrgNr + '</strong>';
                    myList.appendChild(listItem);
                }

                document.getElementById('getSchool').style.visibility = 'hidden';
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