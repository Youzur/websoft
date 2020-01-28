(function () {
    'use strict';

    document.getElementById('getSchool').addEventListener("click", getData);

    function getData() {
        fetch('data/1290.json')
            .then((response) => {
                return response.json();
            })
            .then((myJson) => {
                //console.log(myJson);
                let output = '<h2>Schools</h2>';
                myJson.forEach(function (school) {
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
            });
        console.log('Sandbox MEGA is ready!');
    }

})();