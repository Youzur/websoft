`use strict`;

const express = require(`express`);
const router = express.Router();


router.get("/lotto", (req, res) => {


    let lottObject = {
        lottoNumber: [],
    };



    for (let i = 0; i < 7; i++) {
        let nr = Math.floor(Math.random() * 35 + 1);
        console.info("nr " + nr);
        if (lottObject.lottoNumber.indexOf(nr) !== -1) {
            i--;
            console.info(nr + " is already included, rerolling");
        } else {
            lottObject.lottoNumber[i] = nr;
        }

    }

    res.render('lotto', lottObject);

    console.info("Here is the dices you have rolled.");

    console.info(lottObject.lottoNumber);

    console.info(lottObject.lottoNumber.join());

});

module.exports = router;