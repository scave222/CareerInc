// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

import { Modal } from "../lib/bootstrap/dist/js/bootstrap.bundle";
import { Controllers } from "~/Controllers/JobRecuiterController.cs";
import { View } from "~/Views/Home/Index";

(function ($) {
    var controller = new ScrollMagic.Controller();

    /*------------------------------------*\
        $NUMBERS
    \*------------------------------------*/

    function animateNumber() {
        $(".js-count").each(function () {
            var $this = $(this),
                countTo = $this.attr("data-count");
            $({ countNum: $this.text() }).animate(
                {
                    countNum: countTo
                },
                {
                    duration: 3000,
                    easing: "linear",
                    step: function () {
                        // Count up with commas
                        $this.text(Math.floor(this.countNum).toLocaleString("en"));
                    },
                    complete: function () {
                        // Add comma after done counting
                        $this.text(this.countNum.toLocaleString("en"));
                    }
                }
            );
        });
    }

    new ScrollMagic.Scene({
        triggerElement: ".section"
    })
        .on("enter", function () {
            $(".section").addClass("pod--animated");
            animateNumber();
        })
        .on("leave", function () {
            $(".section").removeClass("pod--animated");
        })
        .addTo(controller);
})(jQuery);

Resources
// Write your JavaScript code.

//const SearchJobs = document.getElementById("SearchJobs");
//const industry = document.getElementById("industry");
//const country = document.getElementById("country");
//const funcarea = document.getElementById("funcarea");
//const jobloca = document.getElementById("jobloca");
//const highqual = document.getElementById("highqual");
//const yrsexp = document.getElementById("yrsexp");
//const reqservice = document.getElementById("reqservice");
//const walk = document.getElementById("walk");
//const searchResult = document.getElementById("searchResult");
//SearchJobs.addEventListener("click", search); 
//function search() {
//    foreach(var item in JobRecuiter.JobRecruiterList.jobRecuiter)
//    {
//        if (item == industry.value || item == country.value || item == funcarea.value || item == jobloca.value || item == highqual.value || item == yrsexp.value || item == reqservice.value || item == walk.value)
//        {
//            searchResult.innerHTML += `
//                                        <table>
//                                            <thead>
//                                            <th>Industry</th>
//                                            <th>Country</th>
//                                            <th>Functional Area</th>
//                                            <th>Job Location</th>
//                                            <th>Highest qualification</th>
//                                            <th>Years of experience</th>
//                                            <th>Required service</th>
//                                            <th>Walkin or Not</th>
//                                            </thead>
//                                            <tbody>
//                                            <td>item.Industry</td>
//                                            <td>item.Country</td>
//                                            <td>item.FunctionalArea</td>
//                                            <td>item.JobLocation</td>
//                                            <td>item.HighestQualification</td>
//                                            <td>item.Experience</td>
//                                            <td>item.RecruitmentService</td>
//                                            <td>item.WalkingOrNot</td>
//                                            </tbody>
//                                        </table>
//                                       `
//        };
//    };
//}



