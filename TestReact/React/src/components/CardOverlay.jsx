import PropTypes from "prop-types";
import { Button } from "react-bootstrap";

export default function ProjectCard({ image, title, content, date, urlText, url }) {
    return <div className="card bg-dark text-white">
        <picture>
            <img className="card-img" src={image} alt="Poplloon Project" height={270} width={723} />

            <div className="card-img-overlay d-flex flex-column align-items-start">
                <h2 className="card-title mx-2 py-2">{title}</h2>
                <h5 className="card-text mx-2 py-2">{content}</h5>
                <h5 className="card-text mx-2 py-2">{date}</h5>

                <a href={url} target="_blank" rel="noopener noreferrer">
                    <Button className="btn btn-dark btn-outline-light my-3 mx-2">
                        {urlText}
                    </Button>
                </a>
            </div>
        </picture>
    </div>
}

ProjectCard.protoTypes = {
    image: PropTypes.string,
    title: PropTypes.string,
    content: PropTypes.string,
    date: PropTypes.string,
    urlText: PropTypes.string,
    url: PropTypes.string
}