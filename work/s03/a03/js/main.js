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
        fetch('data/1290.json')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                document.getElementById("table").innerHTML = JSON.stringify(data);
                document.getElementById('getSchool').style.visibility = 'hidden';
            })

    }

})();