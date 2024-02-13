# ECEN4024 Capstone Project

This repo contains all software related to the development of our 1-DOF motion platform ocean simulator capstone project, sponsored by Lawrence Livermore National Laboratory in conjunction with Oklahoma State University.

1. A GUI interface for a user to interact with our motion platform, in the form of either inputing manual positioning, or uploading pre-computed motion data.
2. An intermediate program that will divide the heave motion between our platform and the pre-build hexapod.
3. (Potentially) An ocean wave simulator capable of deriving motion data in the form of an elevation and normal vector from the surface of a plane being modulated by a parameterized spectrum equation using the technique found in [[Ref. 1]](#references).

---

# References (So far)

1. https://people.computing.clemson.edu/~jtessen/reports/papers_files/coursenotes2004.pdf
2. https://github.com/GarrettGunnell/Water/tree/main
3. https://wikiwaves.org/Ocean-Wave_Spectra
4. https://gpuopen.com/gdc-presentations/2019/gdc-2019-agtd6-interactive-water-simulation-in-atlas.pdf
5. https://github.com/iamyoukou/fftWater
