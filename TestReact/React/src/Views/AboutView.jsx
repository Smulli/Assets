import React, { useState } from "react";
import Collapse from "react-bootstrap/Collapse";
import Button from "react-bootstrap/Button";
import "bootstrap/dist/css/bootstrap.min.css";
import AboutImage from "../Assets/Img/Albert.jpg";
import PropTypes from "prop-types";
import { Helmet } from "react-helmet";

function AboutView({ aboutText, bioText }) {
    const [open, setOpen] = useState(false);

    return <div>
        <Helmet>
            <title>About</title>

            <meta name="description" content="Get info about our startup and his CEO Albert" />
        </Helmet>

        <div className="container d-flex">
            <h5 className="text-center mt-5 mb-5">{aboutText}</h5>
        </div>

        <div className="imgAbout mt-5 align-items-center text-center">
            <picture>
                <Button 
                        variant="link"
                        aria-expanded={open}
                        aria-controls="collapseText"
                    >
                        <img className="img-fluid rounded-circle" src={AboutImage} alt="Albert About" width={350} height={360} onMouseEnter={() => setOpen(!open)} onMouseLeave={() => setOpen(!open)} />
                </Button>
                <Collapse in={open}>
                    <div className="pb-5 text-center container" id="collapseText">
                        <p>{bioText}</p>
                    </div>
                </Collapse>
            </picture>
        </div>
    </div>
}

AboutView.propTypes = {
    aboutText: PropTypes.string
}

export default AboutView