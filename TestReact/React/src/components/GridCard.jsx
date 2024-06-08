import PropTypes from "prop-types";
import { Button } from "react-bootstrap";

export default function GridCard({ title, content, date, btnText, url }) {
    return <div>
        <div className="col card text-white bg-dark">
            <h2 className="card-header pt-2">{title}</h2>
            <div className="card-body">
                <p className="py-3">{content}</p>
                <h5 className="py-3">{date}</h5>
            </div>
            <a href={url} target="_blank" rel="noopener noreferrer">
                <Button className="btn btn-dark btn-outline-light my-3 mx-2">
                    {btnText}
                </Button>
            </a>
        </div>
    </div>
}

GridCard.propTypes = {
    title: PropTypes.string,
    content: PropTypes.string,
    date: PropTypes.string,
    btnText: PropTypes.string,
}