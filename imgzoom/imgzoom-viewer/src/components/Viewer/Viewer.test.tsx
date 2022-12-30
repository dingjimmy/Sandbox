import { render, waitFor, screen } from '@testing-library/react';
import Viewer from './Viewer';
import 'canvas';

test('OpenSeadragon viewer created', async () => {

    // Arrange
    render(<Viewer tileSources={''} />);

    // Act


    // Assert
    expect(document.querySelector('.openseadragon-container'))
        .toBeInTheDocument();
});